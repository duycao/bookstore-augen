<template>
<div>
    <div class="row mb-2">
        <div class="col-md-11">
            <b-form-input @keyup.enter="fetchBooks" v-model="textSearch" placeholder="find books"></b-form-input>
        </div>
        <div class="col-md-1 text-left">
            <b-button block variant="primary" @click="fetchBooks">Find</b-button>
        </div>
    </div>
    <div class="row">
        <app-book v-for="book in books" :key="book.id" @click.native="selectBook(book)">
            <b-card-group deck>
                <b-card :img-src="book.volumeInfo.imageLinks.thumbnail" img-alt="Card image" img-top>
                    <b-card-text>
                        {{book.volumeInfo.title}}
                    </b-card-text>
                    <b-card-text>
                        {{book.volumeInfo.authors[0]}} - {{book.volumeInfo.publishedDate}}
                    </b-card-text>
                </b-card>
            </b-card-group>   
        </app-book>
    </div>
</div>
</template>

<script>
import Book from "./Book";
export default {
    components: {
        appBook:Book
    },
    data: function() {
        return {
            textSearch: '',
            book: {},
            books: []
        }
    },
    methods: {
        selectBook(book) {
            this.$emit('selectedBook',book);
            this.$bvModal.show('bv-modal-example');
        },
        fetchBooks() {
            if(!this.textSearch) {
                alert('please input text to search');
                return;
            }
            this.$http.get(`${this.$rootApi}/books?text=${this.textSearch}`)
                        .then(response=> {
                            return response.json()
                        })
                        .then(data => this.books = data.items)
        }
    }
}
</script>

<style>
.panel-body {
    font-family: 'Arizonia', cursive;
    font-size: 12px;
    color: #6e6e6e;
}
.quote {
    cursor: pointer;
}
.quote:hover {
    background-color: #ffe2e2;
}
</style>