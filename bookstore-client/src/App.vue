<template>
  <div id="app" class="container">
    <app-list-book @selectedBook="selectBook"></app-list-book>
    <app-book-detail :book="book"></app-book-detail>
  </div>
</template>

<script>
import ListBook from './components/ListBook'
import BookDetail from "./components/BookDetail";
export default {
  name: 'app',
  data: function() {
    return {
      book: {}
    }
  },
  components: {
    appListBook: ListBook,
    appBookDetail: BookDetail
  },
  methods: {
    selectBook(book) {
      this.book = book;
    }
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
