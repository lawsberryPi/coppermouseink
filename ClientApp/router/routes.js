import HomePage from './../src/view/home-page'
import ApparelPage from './../src/view/Apparel'

export const routes = [
  { name: 'home', path: '/', component: HomePage, display: 'Home', icon: 'home' },
  { name: 'apparel', path: '/apparel', component: ApparelPage }
]
