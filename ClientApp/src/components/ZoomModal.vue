<template>
    <v-dialog v-model="dialog" fullscreen hide-overlay 
        transition="dialog-bottom-transition">
      <v-card>
        <v-toolbar dark color="primary">
        <v-btn icon dark @click="close(index)">
        <v-icon>close</v-icon>
        </v-btn>
        <v-toolbar-title>View Large Image</v-toolbar-title>
        </v-toolbar>
        <v-img
            :src="image"
            height="100%"
            width="100%"
            contain
        ></v-img>
      </v-card>
    </v-dialog>
</template>

<script>
  export default {
    name: 'ZoomModal',
    props: {
      index: {
        type: Number,
        default: 0
      },
      dialog:{
        type:Boolean,
        default: false
      },
      image: {
        type: String
      },
      close:{
        type:Function
      }
    },

    computed: {
      classes () {
        return {
          'md6': this.size === 2,
          'md4': this.size === 3
        }
      }
    }
  }
</script>