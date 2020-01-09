// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var music = $("#FilePath").val();

if (music) {
    document.addEventListener('DOMContentLoaded', function () {
        var wavesurfer = WaveSurfer.create({
            container: '#waveform',
            waveColor: '#'+Math.floor(Math.random() * 16777215).toString(16),
            progressColor: '#'+Math.floor(Math.random() * 16777215).toString(16)
        });

        wavesurfer.load('../../' + music);

        document
            .querySelector('[data-action="play"]')
            .addEventListener('click', wavesurfer.playPause.bind(wavesurfer));
    });
}



