
//const remainingContent = document.getElementById('remainingContent');
//const content = remainingContent.innerHTML;
//console.log(content);
//const remainingContent = document.getElementById('remainingContent');
////console.log(remainingContent)
//remainingContent.classList.toggle('hidden');

document.addEventListener('DOMContentLoaded', function () {
    setTimeout(function () {
        document.querySelector(".rotate_gift").style.display = "none";
        document.body.style.overflow = "auto"; // Hiển thị thanh cuộn trang
        var contentDiv = document.getElementById('remainingContent');
        contentDiv.style.display = "block";
    }, 5000); // Giả định thời gian tải là 2 giây
    // Thêm mã JavaScript để thực hiện toggle
})
