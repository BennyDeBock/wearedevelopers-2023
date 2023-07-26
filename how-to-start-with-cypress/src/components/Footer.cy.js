import Footer from './Footer.vue'
import '../index.css'

describe('<Footer />', () => {
  it('renders', () => {
    cy.mount(Footer)
  })
})