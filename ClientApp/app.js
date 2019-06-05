import Vue from 'vue'
import axios from 'axios'
import router from './router/index'
import store from './store'
import { sync } from 'vuex-router-sync'
import App from './src/components/app-root'
import Vuetify from 'vuetify'
import { FontAwesomeIcon } from './icons'
import 'vuetify/dist/vuetify.min.css'
// Registration of global components
Vue.use(Vuetify)
Vue.component('icon', FontAwesomeIcon)

Vue.prototype.$http = axios

sync(store, router)

const app = new Vue({
  store,
  router,
  ...App
})

export {
  app,
  router,
  store
}
