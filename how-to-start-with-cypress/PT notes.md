### How to start with Cypress - Hosted by Filip Hric, Cypress Ambassador

### Starting information
- The host has his own [website](https://filiphric.com/) where you can find more information about his workshops
- this workshop is [available on github](https://github.com/filiphric/wearedevs-workshop)
- The host usually uses 2 terminal sessions, one for hosting the app locally and the other for cypress
- The application in this workshop is a trello clone, 
-  The backend is managing a local json file, to keep the project simple. As a bonus it's easier to check the current state while doing the workshop
- The application has devTools enabled, reachable by pressing 'F2'

### Workshop notes
For each test, the json-file will be reset to it's original state. (Consider this a database wipe).

The tests for this project live in the cypress/e2e folder. This repo also contains component testing, but there was not enough time in the workshop @WAD. e2e testing remains the most common purpose for cypress.

#### Test structure
Cypress comes with mocha as a bundled library. It is used to form a structure within the tests.

Use an `it` block to define a single test
```typescript
it('my-first-test', () => {
	//test here
});
```

#### Launching Cypress
After running the application in one terminal session, open a second terminal session and run `npx cypress open`. This will launch cypress. Cypress will check for available browsers on your computer and let you pick a browser from all supported options. Since it runs in a browser, all your normal browser devTools are also available when using cypress.

It also uses the power of devtools, it keeps application snapshots for each state/call that a backend might return. This means you can see your application in intermediate states.
The application is effectively being run in an iframe within cypress.

#### INTERACTION testing
- use `cy.visit('/board/1')` to navigate to a certain route for a test
- if you only want to run a single test from a file, update the `it` block to the following
	-  usage of `it.only` is recommended when you are building a specific test
```typescript
//only this test will be run
it.only('my-first-test', () => {
	//test here
});

it('my-second-test', () => {
	//second test here
});
```

- use `cy.get('selector')` to grab a certain component
	- selector follows DOM/CSS selectors
- Then you can start chaining commands
	- For an input, you can use `.type('text sample {enter}')` to type a text and then hit enter (curly brackets)
	- documentation is found at docs.cypress.io/api/commands
- You can also get an element in a couple of different ways
	- data-cy property
	- css selector
	- contains command (can help select an element that contains a text)
- Cypress has quite good Error logs according to the speaker. For example, click cannot be executed on multiple elements at once.
	- a possible solution is to single out an element from a collection: `get.('something that exits multiple times').first().click()`
- Cypress cannot hover out of the box
	- But a plugin can be used.
	- '[cypress-real-events](https://github.com/dmtrKovalenko/cypress-real-events)' will swap javascript events to actual events, including hover.


#### ASSERTION testing
Some advice: use beforeEach for cleanup. As it guarantees correct data.
AfterEach cleanup would wipe any results you end up with at the end. 

- `cy.get('something').should()` has [very many assertions](https://docs.cypress.io/guides/references/assertions) available.
	- can assert have.length, 2 for a count of elements
	- can assert CSS classes (have.class, 'className')or states (be.checked)"


#### CHAINING AND RETRYABILITY
This is 'VERY IMPORTANT', it encompasses the 'CORE OF CYPRESS PHILOSOPHY'

##### Advanced `contains`
- There's a spcial version of `contains` with 2 params: first is 'get', second is contains
- Using `eq` will only returns the first hit
- `cy.get('list').eq(1).contains('[data-cy=card], 'Mar 1 2022')`
	- this gets the first list element, and checks for elements with selector 'data-cy=card', and content 'Mar 1 2022'

##### Slow loading
You can import functions to mimic slow behavior, like `slowLoading`. For example the default timeout in cypress is 4s (cypress's opinionated timeout for a user losing patience/interest). So what if the app takes 5s to load? 

Options:
- in config you can overwrite defaultCommmandTimeout
- your can put an extra config inside the test,` it('name', {timeout: 6000}, () => {})`
- or even on a command `cy.get('selector', {timeout: 6000})`

 An assertion on a get will **keep retrying** until the timeout is passed.

You have to try to avoid flaky tests: a test that doesn't always have the same result.

There are 3 types of commands: query, action or assertion. An 'action' command in a chain breaks retryability, because only queries and assertions are retried.

So we kind of have to add a guarding condition before actions `(get().eq().SHOULD().click()`

get is a parent command, so cannot be chained onto something
Actions doesn't return anything, so it usually can't be chained 

### INTERCEPTING REQUESTS

Loading data can take a while, a test might wrongfully pass or fail while the api-calls are still pending (Flaky behavior)

So we need to be able to test upon receiving responses.

##### Stabilising a test:
- `cy.intercept({method:'GET', url: 'api/lists?boardId=1'}).as('getLists')` is a call config with alias 'getLists'
- `cy.wait('@getLists')` will pause test execution until we have a result
- You can use a * wildcard in url for the requests, or regex

You can test the api-calls responses:
- `cy.wait('@alias').its('response.statusCode').should('eq', 200)` for statusCode check

You can also manipulate the body of a request
```typescript
cy.intercept({
	method: 'GET',
	url: './rferrer/tgrhehjm/eweqeqwe'

}, {
	body: {...}
})
```

... or point to a fixture
so you can **mock** responses of a real api call.
Benefits:
- test edgeCases
- check how application looks with no data.

Or even check for api-errorcodes, f.e. overwriting statusCode 500

A lot more can be done, dynamic matching/handling of the response

Screenshots can be taken but screenshot diffing isn't part of stock cypress framework

### HTTP REQUESTS
(sending requests yourself) - skipped in workshop, pretty much like postman
Cypress API-testing: referred to [plugin](https://github.com/filiphric/cypress-plugin-api)

### HANDLING AUTHENTICATION: short look only

A custom command was added: login (navigation typing and login inside)
- uses session command, executes a sequence of commands and save all of the storage items you'd get from that

Session has an options to make it cacheAcrossSpecs: true 

### COMPONENT TESTING:
Is a different approach:
	Single component is taken, we mount it and check that that component works well.


Testing is framework-specific, detects framework and bundler combo.

It needs some sort of devServer available, so `ng serve` for angular f.e. 

Convention is to put component-test alongside component files (example in angular: `angular-name.component.spec.ts`)

It can scaffold component test for mounting that component into a test - bit unclear, rushing at the end.

We have to make sure we provide everything that component uses/imports, there's some legwork required, but it is quite fast and works well for cases where we have a form with different validators.
