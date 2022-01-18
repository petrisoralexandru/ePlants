// tailwind.config.js
module.exports = {
  purge: [],
  darkMode: false,
  theme: {
      extend: {
          colors: {
              'primary': '#AAFCB8',
              'secondary': '#8CD790',
              'accent': '#285943',
              'light': '#D7FFF1'
          }
      },
  },
  variants: {
    extend: {},
  },
    plugins: [
        require('@tailwindcss/forms'),
        require('@tailwindcss/typography'),
        require('@tailwindcss/aspect-ratio')
    ],
}