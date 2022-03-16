/*
	By Osvaldas Valutis, www.osvaldas.info
	Available for use under the MIT License
*/

'use strict';

; (function (document, window, index) {
	var inputs = document.querySelectorAll('.inputfile');
	var p = document.getElementById('errorMusic');
	var addSong = document.getElementById('addSong')

	Array.prototype.forEach.call(inputs, function (input) {
		var label = input.nextElementSibling, labelVal = label.innerHTML;

		input.addEventListener('change', function (e) {
			var fileName = '';
			if (this.files && this.files.length > 1)
				fileName = (this.getAttribute('data-multiple-caption') || '').replace('{count}', this.files.length);
			else
				fileName = e.target.value.split('\\').pop();

			//regex

			const regex = /^[A-Za-z0-9-_ ]+$/;
			console.log(regex.test(fileName.replace('.mp3', '')))
			if (regex.test(fileName.replace('.mp3', ''))) {
				p.style = "display:none"
				addSong.style = "display:visible"
			} else {
				p.style = "display:visible"
				addSong.style = "display:none"
			}



			if (fileName)
				label.querySelector('span').innerHTML = fileName;
			else
				label.innerHTML = labelVal;
		});

		// Firefox bug fix
		input.addEventListener('focus', function () { input.classList.add('has-focus'); });
		input.addEventListener('blur', function () { input.classList.remove('has-focus'); });
	});
}(document, window, 0));