import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

// STATE
const state = {
  counter: 1,
  drawer: false,
  userName: null,
  items: [
    {
      text: 'Home',
      to: '/'
    },
    {
      text: 'T-Shirt',
      to: '/tShirt'
    }
  ]
}

// MUTATIONS
const mutations = {
  mainSetCounter: (state, obj) => (state.counter = obj.counter),
  setDrawer: (state, payload) => (state.drawer = payload),
  toggleDrawer: state => (state.drawer = !state.drawer),
  setUserInfo: (state, googleUsers) => {
    state.userName = googleUsers
  }
}

// ACTIONS
const actions = ({
  setCounter ({ commit }, obj) {
    commit('mainSetCounter', obj)
  }
})

export default new Vuex.Store({
  state,
  mutations,
  actions
})
