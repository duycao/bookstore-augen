<template>
  <div id="app" class="container">
    <app-list-book></app-list-book>
    <app-book-detail></app-book-detail>
  </div>
</template>

<script>
import ListBook from './components/ListBook'
import BookDetail from "./components/BookDetail";
export default {
  name: 'app',
  data() {
    return {
      //selectedBook: this.$store.state.book
    }
  },
  computed: {
    selectedBook() {
      return this.$store.state.book
    } 
  },
  components: {
    appListBook: ListBook,
    appBookDetail: BookDetail
  },
  methods: {
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
