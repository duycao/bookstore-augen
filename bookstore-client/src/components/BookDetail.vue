<template>
  <b-modal id="bv-modal-example" hide-footer>
    <template v-slot:modal-title v-if="book.volumeInfo">
      {{book.volumeInfo.title}}
    </template>
    <div class="d-block text-center" v-if="book.volumeInfo">
      <b-card-group deck>
        <b-card :img-src="book.volumeInfo.imageLinks.thumbnail" img-alt="Card image" img-left class="mb-2">
            <b-card-text>
                <div class="overflow-auto text-left description" style="max-height:160px;">
                    {{book.volumeInfo.description}}
                </div>
            </b-card-text>
        </b-card>
        
      </b-card-group>
        <div class="row title">
            <div class="col-6 text-left">
                <b-card-text>
                    {{book.volumeInfo.title}}
                </b-card-text>
                <b-card-text>
                    {{book.volumeInfo.authors[0]}} - {{book.volumeInfo.publishedDate}}
                </b-card-text>
            </div>
        </div>
    </div>
    <div class="row mt-2 ">
        <div class="col-12 ">
            <p class="border-bottom border-secondary">Ship via</p>
        </div>
    </div>
    <b-row class="text-center">
        <b-col lg="4" class="pb-2"><b-button variant="success" class="small-text" pill size="sm" @click="buyBook('MOTOBIKE',5.00)">MOTOBIKE 5.00</b-button></b-col>
        <b-col lg="4" class="pb-2">
            <b-button variant="primary" class="small-text" pill size="sm" @click="buyBook('TRAIN',10.00)">TRAIN $10.00</b-button>
            </b-col>
        <b-col lg="4" class="pb-2"><b-button variant="warning" class="small-text" pill size="sm" @click="buyBook('AIRCRAFT',20.00)">AIRCRAFT $20.00</b-button></b-col>
    </b-row>
    <b-row class="text-center">
        <p class="text-success">{{buyResponse}}</p>
    </b-row>
  </b-modal>
</template>

<script>
export default {
    props: ['book'],
    data: function() {
        return {
            buyResponse: ""
        }
    },
    methods: {
        buyBook(service,cost) {
            const buyBookModel = {DeliveryService: service,DeliveryCost:cost};
            this.$http.post(`${this.$rootApi}/books`,buyBookModel)
                    .then(response=> {
                        return response.json()
                    })
                    .then(data=>this.buyResponse=`Thank you. Your delivery man : ${data.driver} - contact phone: ${data.phone} - Delivery Service: ${data.deliveryService} - Delivery Cost: $${data.deliveryCost}`);
        }
    },
    mounted() {
        this.$root.$on('bv::modal::hide', () => {
        this.buyResponse="";
        })
    }
}
</script>

<style>
    .small-text {
        font-size: 0.7rem !important;
    }
    .title {
        font-family: 'Arizonia', cursive;
        font-size: 12px;
        color: #6e6e6e;
    }
    .description {
        font-size: 12px;
    }
</style>