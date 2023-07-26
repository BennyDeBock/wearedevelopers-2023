import SaveButton from './SaveButton.vue'

describe('<SaveButton />', () => {
  it('renders', () => {
    cy.mount(SaveButton, {
      buttontext: 'button'
    })
  })
})