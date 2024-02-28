/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./index.html', './src/**/*.{html,js,ts,jsx,tsx,vue}',
    require('path').join(
      require.resolve('daisyui'),
      '../**/*.{html,js,ts,vue}'
    ),
  ],
  theme: {
    extend: {},
  },
  plugins: [require("daisyui")],
};