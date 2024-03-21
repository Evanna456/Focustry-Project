<template>
  <q-page style="min-height: 0">
    <div class="row justify-center">
      <div class="col-lg-12" align="center">
        <div class="card max-w-[600px] w-full bg-base-100 shadow-xl mt-[5%]">
          <div class="card-body">
            <h2 class="text-center text-[20px]"><strong>Register</strong></h2>
            <label class="input input-bordered flex items-center gap-2">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 16 16"
                fill="currentColor"
                class="w-4 h-4 opacity-70"
              >
                <path
                  d="M8 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6ZM12.735 14c.618 0 1.093-.561.872-1.139a6.002 6.002 0 0 0-11.215 0c-.22.578.254 1.139.872 1.139h9.47Z"
                />
              </svg>
              <input
                type="text"
                class="grow"
                v-model="firstname"
                placeholder="Firstname"
              />
            </label>
            <label class="input input-bordered flex items-center gap-2">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 16 16"
                fill="currentColor"
                class="w-4 h-4 opacity-70"
              >
                <path
                  d="M8 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6ZM12.735 14c.618 0 1.093-.561.872-1.139a6.002 6.002 0 0 0-11.215 0c-.22.578.254 1.139.872 1.139h9.47Z"
                />
              </svg>
              <input
                type="text"
                class="grow"
                v-model="lastname"
                placeholder="Lastname"
              />
            </label>
            <label class="input input-bordered flex items-center gap-2">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 16 16"
                fill="currentColor"
                class="w-4 h-4 opacity-70"
              >
                <path
                  d="M8 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6ZM12.735 14c.618 0 1.093-.561.872-1.139a6.002 6.002 0 0 0-11.215 0c-.22.578.254 1.139.872 1.139h9.47Z"
                />
              </svg>
              <input
                type="text"
                class="grow"
                v-model="username"
                placeholder="Username"
              />
            </label>
            <label class="input input-bordered flex items-center gap-2">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 16 16"
                fill="currentColor"
                class="w-4 h-4 opacity-70"
              >
                <path
                  fill-rule="evenodd"
                  d="M14 6a4 4 0 0 1-4.899 3.899l-1.955 1.955a.5.5 0 0 1-.353.146H5v1.5a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-2.293a.5.5 0 0 1 .146-.353l3.955-3.955A4 4 0 1 1 14 6Zm-4-2a.75.75 0 0 0 0 1.5.5.5 0 0 1 .5.5.75.75 0 0 0 1.5 0 2 2 0 0 0-2-2Z"
                  clip-rule="evenodd"
                />
              </svg>
              <input type="password" class="grow" v-model="password" />
            </label>
            <button class="btn btn-wide w-full" v-on:click="registerUser">
              Submit
            </button>
          </div>
        </div>
      </div>
    </div>
  </q-page>
</template>

<style scoped></style>

<script lang="ts">
import { defineComponent, PropType } from 'vue';
import Validator from '../../public/libs/lara-validationjs/validator.js';
import axios from 'axios';
import Users from '../models/Users';
export default defineComponent({
  name: 'RegisterPage',
  props: {
    users: {
      type: Object as PropType<Users>,
    },
  },
  data: function () {
    return {
      firstname: this.$props.users?.FirstName,
      lastname: this.$props.users?.LastName,
      username: this.$props.users?.Username,
      password: this.$props.users?.Password,
    };
  },
  methods: {
    registerUser() {
      const _validator = new Validator();
      var data = this.$data;
      _validator.make(
        data,
        {
          firstname: 'required',
          lastname: 'required',
          username: 'required',
          password: 'required',
        },
        (messages: any) => {
          required: 'The :attribute field is required';
        },
      );
      if (_validator.fails()) {
        alert(_validator.first().error);
        return;
      }
      axios
        .post(
          'http://localhost:8000/api/register',
          {
            firstname: this.$data.firstname,
            lastname: this.$data.lastname,
            username: this.$data.username,
            password: this.$data.password,
          },
          {
            headers: {
              'Access-Control-Allow-Origin': '*',
              'Access-Control-Allow-Methods':
                'GET,PUT,POST,DELETE,PATCH,OPTIONS',
            },
          },
        )
        .then(function (response: any) {
          console.log('Success');
        });
    },
  },
});
</script>
../models/Users.js
