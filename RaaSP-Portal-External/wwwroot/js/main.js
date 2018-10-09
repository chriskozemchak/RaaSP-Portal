/*
	Prologue by HTML5 UP
	html5up.net | @ajlkn
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
*/

(function($) {

	var	$window = $(window),
		$body = $('body'),
        $nav = $('#nav');

    var projectList = [
        "ActionScript Investigation",
        "AppleScript Study",
        "Asp And You",
        "BASIC Environment",
        "Project C",
        "Study C++",
        "Clojure Environment",
        "COBOL",
        "ColdFusion Environment",
        "Erlang",
        "Fortran Environment",
        "Groovy Study",
        "Haskell",
        "Java",
        "JavaScript",
        "Lisp",
        "Perl Research",
        "PHP Research",
        "Python",
        "Research Ruby",
        "Scala Environment",
        "Environment Scheme"
    ];
    var ctsaList = [
    "Arkansas Center for Clinical & Translational Research",
    "Atlanta Clinical and Translational Science Institute(Atlanta - CTSI)",
    "Boston University / Boston Medical Center Clinical and Translational Science Institute(BU - BRIDGE)",
    "Colorado Clinical and Translational Sciences Institute",
    "CTSA at Case Western University",
    "CTSA at Weill Cornell Medical College",
    "Einstein - Montefiore Institute for Clinical and Translational Research",
    "Harvard Catalyst: The Harvard Clinical and Translational Science Center",
    "Indiana Clinical and Translational Sciences Institute",
    "Irving Institute for Clinical & Translational Research",
    "Johns Hopkins Institute for Clinical and Translational Research",
    "Mayo Center for Translational Science Activities",
    "Michigan Institute of Clinical and Health Research",
    "Mount Sinai Institutes of Clinical and Translational Sciences",
    "North and Central Texas Clinical and Translational Science Initiative",
    "NYU - HHC Clinical and Translational Science Institute",
    "Ohio State University Center for Clinical and Translational Science",
    "Oregon Clinical and Translational Research Institute",
    "Rockefeller University Center for Clinical and Translational Science",
    "Scripps Translational Science Institute",
    "South Carolina Clinical & Translational Research Institute",
    "Stanford Center for Clinical and Translational Education and Research",
    "Tufts Clinical and Translational Science Institute",
    "UAB Center for Clinical and Translational Science",
    "UC Davis Clinical and Translational Science Center",
    "UNC - CH North Carolina Translational and Clinical Sciences(TraCS) Institute",
    "University of Cincinnati Center for Clinical and Translational Science and Training",
    "University of Florida's Clinical and Translational Science Institute",
    "University of Illinois at Chicago Center for Clinical and Translational Science",
    "University of Iowa's Institute for Clinical and Translational Science ",
    "University of Pennsylvania Institute for Translational Medicine and Therapeutics",
    "University of Rochester Clinical and Translational Science Institute",
    "University of Texas Health Science Center at San Antonio - Institute for Integration of Medicine and Science(IIMS)",
    "University of Texas Houston Center for Clinical and Translational Sciences",
    "University of Utah Center for Clinical and Translational Science",
    "University of Washington Institute of Translational Health Sciences",
    "University of Wisconsin - Madison Institute for Clinical and Translational Research",
    "UTMB Institute for Translational Sciences",
    "Vanderbilt Institute for Clinical and Translational Research",
    "Washington University Institute of Clinical and Translational Sciences",
    "Yale Center for Clinical Investigation",

    ];
	// Breakpoints.
		breakpoints({
			wide:      [ '961px',  '1880px' ],
			normal:    [ '961px',  '1620px' ],
			narrow:    [ '961px',  '1320px' ],
			narrower:  [ '737px',  '960px'  ],
			mobile:    [ null,     '736px'  ]
		});

	// Play initial animations on page load.
		$window.on('load', function() {
			window.setTimeout(function() {
				$body.removeClass('is-preload');
			}, 100);
		});

	// Nav.
		var $nav_a = $nav.find('a');

		$nav_a
			.addClass('scrolly')
			.on('click', function(e) {

				var $this = $(this);

				// External link? Bail.
					if ($this.attr('href').charAt(0) != '#')
						return;

				// Prevent default.
					e.preventDefault();

				// Deactivate all links.
					$nav_a.removeClass('active');

				// Activate link *and* lock it (so Scrollex doesn't try to activate other links as we're scrolling to this one's section).
					$this
						.addClass('active')
						.addClass('active-locked');

			})
			.each(function() {

				var	$this = $(this),
					id = $this.attr('href'),
					$section = $(id);

				// No section for this link? Bail.
					if ($section.length < 1)
						return;

				// Scrollex.
					$section.scrollex({
						mode: 'middle',
						top: '-10vh',
						bottom: '-10vh',
						initialize: function() {

							// Deactivate section.
								$section.addClass('inactive');

						},
						enter: function() {

							// Activate section.
								$section.removeClass('inactive');

							// No locked links? Deactivate all links and activate this section's one.
								if ($nav_a.filter('.active-locked').length == 0) {

									$nav_a.removeClass('active');
									$this.addClass('active');

								}

							// Otherwise, if this section's link is the one that's locked, unlock it.
								else if ($this.hasClass('active-locked'))
									$this.removeClass('active-locked');

						}
					});

			});

	// Scrolly.
		$('.scrolly').scrolly();

	// Header (narrower + mobile).

		// Toggle.
			$(
				'<div id="headerToggle">' +
					'<a href="#header" class="toggle"></a>' +
				'</div>'
			)
				.appendTo($body);

		// Header.
			$('#header')
				.panel({
					delay: 500,
					hideOnClick: true,
					hideOnSwipe: true,
					resetScroll: true,
					resetForms: true,
					side: 'left',
					target: $body,
					visibleClass: 'header-visible'
        });
    //AutoComplete

    $('.projects').autocomplete({
        source: projectList
    });
    $('.ctsa').autocomplete({
        source: ctsaList
    });
    $('.toggle').on("click", function(){
        showHide();
    });
    function showHide(){
        $('#basic').toggle('fade', 500)
        $('#investigator').toggle('fade', 500)
	};
	$('.submit').on("click", function(){
        submitRegistration();
    });
	function submitRegistration(){
        $('#registration').toggle('fade', 500)
		$('#submission').toggle('fade', 500) 
    };
	$( ".dialog" ).dialog({ 
		autoOpen: false ,
		resizable: false,
		height: "auto",
		width: "auto",
		modal: true,
	});
	$( ".opener" ).click(function() {
	  $( ".dialog" ).dialog( "open");
	});
	$( ".dialog2" ).dialog({ autoOpen: false,
		autoOpen: false ,
		resizable: false,
		height: "auto",
		width: "auto",
		modal: true,
	 });
	$( ".opener2" ).click(function() {
	  $( ".dialog2" ).dialog("open" );
	});
	$( ".dialog3" ).dialog({ autoOpen: false,
		autoOpen: false ,
		resizable: false,
		height: "auto",
		width: "auto",
		modal: true,
	 });
	$( ".opener3" ).click(function() {
	  $( ".dialog3" ).dialog("open" );
	});
	$( ".dialog4" ).dialog({ autoOpen: false,
		autoOpen: false ,
		resizable: false,
		height: "auto",
		width: "auto",
		modal: true,
	 });
	$( ".opener4" ).click(function() {
	  $( ".dialog4" ).dialog("open" );
	});
})(jQuery);