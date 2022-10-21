import './App.css';
import { Component } from 'react';

class Header extends Component {
  render() {
    return (
      <div class="header-member">
        <h1 >Group's Members</h1>
      </div>
    )
  }
}

class Blogs extends Component {
  state = {
    vote: "MIN" 
  }

  addVote = () => {
    if (this.state.vote === "MIN") {
      this.setState({ vote: 1 })
    }
    else if (this.state.vote < 10) {
      this.setState({ vote: this.state.vote + 1 })
      if (this.state.vote === 9) {
        this.setState({ vote: "MAX" })
      }
    } 
    else {
      alert("Cannot Vote")
    }
  }

  removeVote = () => {
    if (this.state.vote === "MAX") {
      this.setState({ vote: 9 })
    }
    else if (this.state.vote > 0) {
      this.setState({ vote: this.state.vote - 1 })
      if (this.state.vote === 1) {
        this.setState({ vote: "MIN" })
      }
    } 
    else {
      alert("Cannot Unvote")
    }
  }

  render() {
    return (
      <div>
        <div class="bgblog">
          <h1>{this.props.name}</h1>
          <img src={this.props.img} alt="" class="pic"></img>
          <h2>{this.props.studentID}</h2>
          <div class="flex-content">
            <p>{this.props.content}</p>
          </div>
          <div class="buttongroup">
            <div class="flexbutton">
              <button class="buttons" onClick={this.addVote}>Click to Vote</button>
              <div class="vote"><h2>{this.state.vote}</h2></div>
              <button class="buttons" onClick={this.removeVote}>Click to Unvote</button>
            </div>
          </div>
        </div>
      </div>
    ); 
    // this.props is used to access the properties of the component
  }
}

class Main extends Component {

  render() {
    return (
      <div>
        <Header />
        <Blogs name="ชิษณุพงศ์ บุญมา" studentID="64015031" img="https://cdn3.iconfinder.com/data/icons/avatars-round-flat/33/man5-512.png"
          content="Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma 
          Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma 
          Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma
          Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma Chidsanupong Boonma" />

        <Blogs name="นฤนาถ ตันตื้อ" studentID="64015068" img="https://cdn3.iconfinder.com/data/icons/avatars-round-flat/33/man5-512.png"
          content="Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue 
          Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue 
          Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue
          Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue
          Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue
          Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart Tuntue Narunart" />

        <Blogs name="วันบุรฮาน แวอุเซ็ง" studentID="64015130" img="https://cdn3.iconfinder.com/data/icons/avatars-round-flat/33/man5-512.png"
          content="Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng 
          Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng 
          Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng
          Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng Wanburhan Wae-Useng" />

        <Blogs name="เอกรินทร์ องอาจ" studentID="64015172" img="https://cdn3.iconfinder.com/data/icons/avatars-round-flat/33/man5-512.png"
          content="Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart 
          Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart 
          Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart
          Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart
          Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart
          Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart
          Aekarin Ongart Aekarin Ongart Aekarin Ongart Aekarin Ongart" />
      </div>
    )
  }
}

export default Main; // แสดงผลในหน้าเว็บ โดยใช้ Component Main