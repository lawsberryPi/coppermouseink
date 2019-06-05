<template>
  <v-app 
  dark>
    <nav-menu params="route: route"></nav-menu>
    <v-content>
      <v-container fluid>
        <router-view></router-view>
      </v-container>
    </v-content>
  </v-app>
</template>
<script>
    import NavMenu from './../components/nav-menu'
    export default {
      components: {
        'nav-menu': NavMenu
      },

      data () {
        return {}
      }
    }
</script>

<style>
</style>
