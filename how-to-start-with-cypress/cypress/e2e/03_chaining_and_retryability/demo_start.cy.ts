import { cardsLoadRandomly, cardsLoadSlowly } from "../../../workshop-scripts/evilCode";

it('opens a card with due date on 1st March', () => {

  cy.visit('/board/1')

  cy.contains('[data-cy=card]', 'Mar 01 2022')
  
  cy.get('[data-cy=list]')
    .eq(1)
    .contains('[data-cy=card]', 'Mar 01 2022')
    
})

it('loads cards in our list very slowly', /*{ defaultCommandTimeout: 6000 },*/ () => {
  cardsLoadSlowly(5000)

  cy.visit('/board/1')

  cy.get('[data-cy=card-text]', { timeout: 6000 })
    .should('have.length', 5)
  
});

it.only('loads cards in our list randomly', () => {
  cardsLoadRandomly(3000)

  cy.visit('/board/1') // Action

  cy.get('[data-cy=card-text]') // Query
    .eq(1) // Query
    .should('contain.text', 'Bread')
    .click() // Action breaks chain/retryability

  cy.get('[data-cy="card-detail-title"]')
    .should('contain.value', 'Bread') // Assertion
  
});

