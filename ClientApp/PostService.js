/* eslint-disable indent */
/* eslint-disable space-before-blocks */
/* eslint-disable brace-style */
import axios from 'axios'
// import { resolve } from 'url';
// import { rejects } from 'assert';

const url = 'api/UserManager/'

// eslint-disable-next-line space-before-blocks
class PostService{
// get post
// eslint-disable-next-line space-before-function-paren
static getPost() {
    return new Promise(async (resolve, reject) =>
    {
      try {
        const res = await axios.get(url)
            // eslint-disable-next-line indent
            const data = res.data
            console.log(data)
        } catch (err) {
            reject(err)
        }
    })
    }

// create post
    static addUserPost (userObj){
        const loginInfo = JSON.stringify(userObj)
        return axios.get(`UserManager/AddUser?userObject=${loginInfo}`)
    }

// delete post
    static deletePost (id){
        return axios.delete(`${url}${id}`)
    }
}

export default PostService
