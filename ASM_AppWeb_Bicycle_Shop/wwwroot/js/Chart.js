
function DefaultData() {
    const data = [
        ['Revenue source', 'Quantity sold'],
        ['Sport bicycle', 11],
        ['Bicycle racing', 2],
        ['Tourist bike', 2],
        ['Bicycle for children', 20],
        ['Electric bicycle',23]
    ];
    return data;
}


google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(drawChart2);

function drawChart2() {

    var data = google.visualization.arrayToDataTable(DefaultData());

    var options = {
        width: 350,
        height: 300,
        title: ''
    };

        var chart = new google.visualization.PieChart(document.getElementById('piechart'));

    chart.draw(data, options);
}


google.charts.load('current', { 'packages': ['bar'] });
google.charts.setOnLoadCallback(drawStuff);

function drawStuff() {
    var data = new google.visualization.arrayToDataTable([
        ['Months', 'Earnings'],
        ["January", 100],
        ["February", 31],
        ["March", 12],
        ["April", 10],
        ["May", 10],
        ["June", 10],
        ["July", 10],
        ["August", 10],
        ["September", 10],
        ["October", 10],
        ["November", 10],
        ['December', 3]
    ]);

    var options = {
        legend: { position: 'none' },
        axes: {
            x: {
                0: { side: 'bottom', label: 'Month' } // Top x-axis.
            }
        },
        bar: { groupWidth: "100%" }
    };

    var chart = new google.charts.Bar(document.getElementById('top_x_div'));
    // Convert the Classic options to Material options.
    chart.draw(data, google.charts.Bar.convertOptions(options));


    google.charts.load('current', {'packages':['corechart']});
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
        var data = google.visualization.arrayToDataTable([
            ['Year', 'Sales', 'Expenses'],
            ['2019',  1000,      400],
            ['2020',  1170,      460],
            ['2021',  660,       1120],
            ['2022', 1030,       540],
            ['2023', 1030,       540]
            ]);

        var options = {
            curveType: 'function',
            legend: {position: 'bottom' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

        chart.draw(data, options);
    }
};
