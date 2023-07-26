it('creates a new list with a card in it', () => {

  cy.visit('/board/1')

  cy.get('[data-cy="add-list-input"]')
    .type('new list{enter}')

  cy.contains('Add another card')
    .click()

  cy.get('[data-cy="new-card-input"]')
    .type('new card{enter}')
});

it.only('bookmarks a board', () => {

  cy.visit('/')

  cy.get('[data-cy="star"]')
    .eq(0)
    .click()
})
