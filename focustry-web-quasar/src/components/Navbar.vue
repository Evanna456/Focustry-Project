<template>
   <div class="row justify-center">
   <div class="col-lg-8" align="center">
<div class="navbar bg-base-100">
    <div class="flex-1">
      <a class="btn btn-ghost text-xl">Focustry</a>
    </div>
    <div class="flex-none">
      <ul class="menu menu-horizontal px-1">
        <li><a>Link</a></li>
        <li>
          <details>
            <summary>
              Parent
            </summary>
            <ul class="p-2 bg-base-100 rounded-t-none">
              <li><a>Link 1</a></li>
              <li><a>Link 2</a></li>
            </ul>
          </details>
        </li>
      </ul>
    </div>
</div>
</div>
</div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
export default defineComponent({
  name: 'Navbar'
});
</script>