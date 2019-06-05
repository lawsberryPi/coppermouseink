<template>
    <div>
        <v-toolbar
          app
          flat
          card
          :extended="true"
        >
    <v-container
      mx-auto
      py-0
      :align-content-center="true"
    >
      <v-layout>
              <v-flex xs3>
                <div @click="onGotoMainPage"> 
                  <h3 class="pt-3">Copper Mouse INK</h3>
                </div>
              </v-flex>
              <v-flex xs2>
              </v-flex>
              <v-flex xs2>
                <v-img
                  :src="require('./../assets/logo.png')"
                  class="mr-5 text-xs-center"
                  contain
                  height="100%"
                  width="100%"
                  max-width="150%"
                  max-height="100%"
                  @click="onGotoMainPage"
                />
              </v-flex>
              <v-flex xs4>
              </v-flex>
        <v-spacer /> 
        <v-btn icon>
          <v-icon>message</v-icon>
        </v-btn>
        <v-btn icon>
          <v-icon>shopping_cart</v-icon>
        </v-btn>
        <login/>
      </v-layout>
    </v-container>
  </v-toolbar>
    </div>
</template>

<script>
    import { routes } from '../../router/routes'
    import {mapGetters, mapMutations} from 'vuex'
    import login from './Login'
    export default {
      components:{
        login
      },
      data () {
        return {
          routes,
          collapsed: true
        }
      },
      methods: {
        ...mapMutations(['toggleDrawer']),
        onClick (e, item) {
          e.stopPropagation()

          if (item.to || !item.href) return

          this.$vuetify.goTo(item.href)
        },
        toggleCollapsed: function (event) {
          this.collapsed = !this.collapsed
        },
        onGotoMainPage(){
          console.log("go to main page")
          this.$router.push('/')
        },
      }
    }
</script>

<style scoped>
    .slide-enter-active, .slide-leave-active {
    transition: max-height .35s
    }
    .slide-enter, .slide-leave-to {
    max-height: 0px;
    }

    .slide-enter-to, .slide-leave {
    max-height: 20em;
    }
</style>
