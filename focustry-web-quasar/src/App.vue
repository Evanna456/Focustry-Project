<template>
  <q-layout
    container
    style="height: calc(100vh)"
    class="shadow-2 rounded-borders"
  >
    <router-view />
  </q-layout>
</template>

<style></style>

<script lang="ts">
import { defineComponent } from 'vue';
import './css/app.css';

export default defineComponent({
  name: 'App',
});
</script>
