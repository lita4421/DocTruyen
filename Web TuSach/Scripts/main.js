function DangXuat() {
    document.cookie = "taikhoan=00";
    document.cookie = "matkhau=00";
}

document.querySelector(".dropdown").addEventListener("click", function () {
    if (document.querySelector(".dropdown-item").getAttribute("active") == "true") {

        document.querySelector(".dropdown-item").style.display = "none";
        document.querySelector(".dropdown-item").setAttribute("active", "false");

    } else {

        document.querySelector(".dropdown-item").style.display = "block";
        document.querySelector(".dropdown-item").setAttribute("active", "true");
    }
    
})
