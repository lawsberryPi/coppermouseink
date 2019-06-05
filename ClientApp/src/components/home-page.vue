<template>
  <div>
    <v-layout>
      <v-flex xs12>
        <v-card>
          <v-img
            class="white--text"
            :src="tshirtImage"
          >
            <v-container fill-height fluid>
              <v-layout fill-height>
                <v-flex xs12 align-end flexbox>
                  <span class="headline">T-Shirt</span>
                </v-flex>
              </v-layout>
            </v-container>
          </v-img>
          <v-card-title>
            <div>
              <span>we focus on delivering your personalized apparel</span><br>
            </div>
          </v-card-title>
          <v-card-actions>
            <v-btn flat 
            color="orange"
            @click="shareMethod">Share</v-btn>
            <v-btn flat color="orange">Explore</v-btn>
            <v-btn flat>Snail Button</v-btn>
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </div>
</template>

<script>
export default {
  data () {
    return {
      tshirtImage:require('./../assets/articles/banners.png')
    }
  },
  methods:{
    shareMethod(input){
      console.log("click share")
    },
    exploreMethod(input){
      console.log()
    }
  }
}
</script>

<style>

</style>
