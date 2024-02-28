<template>
  <q-layout>
    <q-page-container>
      <Navbar />
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import Navbar from '../components/Navbar.vue';

export default defineComponent({
  name: 'MainLayout',
  components: { Navbar },
});
</script>
