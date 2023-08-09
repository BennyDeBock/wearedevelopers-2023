Monolithic vs Microservices vs Serverless vs SOA vs EDA

We usually don't know much about the future systems when we make a lot of the decisions for the systems.

Gall's Law. Easy to make things complicated, but complicated to make things simple.

### Evolutionary architecture
Software needs agility to be able to change
- incremental
	- Your customer likely wants more and more features
	- However we should keep in mind that the solution also needs to be able to upscale
- Fitness functions
- Multiple dimensions
	- Satisfy the business demands, but also enduser demands?? (unclear)
### Scenario
Mapping user requirements to IT requirements adds a risk to cause misunderstandings or mistakes
There's a certain domain model shown for a coding example
Left side represents Orders-part in an application
Right side represents Stock-part of a separate application

#### Hands-on session: design/implement a solution
- monolithic solution: 
	- easier to develop
	- performance
	- simplified testing
	- easy deployment
- Microservices solution:
	- agility
	- flexible scaling
	- continuous development
	- maintainable/testeable
	- independantly deployable
	- technology flexibility

- Integration-event -> shared event between the systems

Evolutionary architecture: 
Monolithic solution with modules that are separated into RDBMS with separate schemas
Slides are also available in the [Repo](github.com/Ace68/WeAreDevelopers-2023)

Minimal Api in .Net is used 
- new concept in .Net6 
- create api in a similar to node.js express framework

Communication between objects: then use messages.
Usage of IMediator 
sometimes named serviceBus
Publishing commands/requests is possible

Jump to testing: 
- testing if interfaces are only implemented within a module namespace
- Full decoupling can be tested somehow
  
  I need a few beers after this





