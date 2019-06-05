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
            <v-btn flat 
            color="orange"
            @click="exploreMethod">Explore</v-btn>
            <v-btn
              color="success"
              @click="changeIconColor"
              large>snail</v-btn>
            <v-btn flat icon
                   :color="iconColor">
              <v-icon>thumb_up</v-icon>
            </v-btn>
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
      tshirtImage:require('./../assets/articles/banners.png'),
      iconColor: "indigo",
      colorSelection:["blue","purple","green","orange","red","yellow"]
    }
  },
  methods:{
    shareMethod(input){
      console.log("click share")
    },
    exploreMethod(input){
      this.$router.push('apparel')
    },
    changeIconColor() {
      var item = this.colorSelection[Math.floor(Math.random() * this.colorSelection.length)];
      this.iconColor = item
    }
  }
}
</script>

<style>

</style>
