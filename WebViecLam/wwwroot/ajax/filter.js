function filterCompany(filterString) {
        $.ajax({
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/Filter',
            data: { filterString: filterString },
            success: function (data) {
                displayFilterResults(data);
            },
            error: function (error) {
                console.log(error);
            }
        });
};

    function displayFilterResults(data) {
        var resultsDiv = $("#searchResults");
        resultsDiv.empty();

        if (data != null) {
            $.each(data, function (index, item) {
                var html = `<div class="product slick-slide slick-current" tabindex="-1" style="width: 335px;" data-slick-index="0" aria-hidden="false">
											<div class="product-img">
											<img src="`+ item.company.companyImage + `" alt="">
												<div class="product-label">
													<span class="new">NEW</span>
												</div>
											</div>
											<div class="product-body">
										<h4 class="product-price">Công ty `+ item.company.companyName + `</h4>
												<h3 class="product-name"><a href="#" tabindex="-1">Vị trí tuyển dụng: `+ item.jobName + `</a></h3>
										<p class="product-category ">Số lượng tuyển: `+ item.jobQuantity + ` </p>
												
												
											</div>
											<div class="add-to-cart">
										<button class="add-to-cart-btn" tabindex="-1"><a href="Jobs/JobDetails?id=`+ item.jobId + `">Xem chi tiết	</a> </button>
											</div>
										</div>`;
                resultsDiv.append(html);
            });
        } else {
            resultsDiv.text("Không tìm thấy kết quả.");
        }
    };
