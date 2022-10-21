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
    value1: "MIN" // กำหนดค่าเริ่มต้นของ value1 เป็น MIN
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
              <button class="buttons" type="button" onClick="">Click to Vote</button>
              <div class="vote"><h2>{this.state.value1.toString()}</h2></div>
              <button class="buttons" type="button" onClick="">Click to Unvote</button>
            </div>
          </div>
        </div>
      </div>
    ); 
    // ใช้ this.props.name เพื่อแสดงค่าของ name
    // ใช้ this.props.img เพื่อแสดงค่าของ img
    // ใช้ this.props.studentID เพื่อแสดงค่าของ studentID
    // ใช้ this.props.content เพื่อแสดงค่าของ content
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