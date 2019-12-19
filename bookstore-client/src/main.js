import Vue from 'vue'
import App from './App.vue'
import BootstrapVue from 'bootstrap-vue'
import VueResource from 'vue-resource'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import {store} from './store/store'

Vue.config.productionTip = false
Vue.prototype.$rootApi = process.env.VUE_APP_ROOT_API
Vue.use(BootstrapVue)
Vue.use(VueResource)

new Vue({
  store,
  render: h => h(App),
}).$mount('#app')
