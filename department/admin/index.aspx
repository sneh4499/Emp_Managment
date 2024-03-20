<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="department_admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

    <script src="../../assets/js/fullcalendar/fullcalendar.min.js"></script>
    <script src="../../assets/js/fullcalendar/gcal.js"></script>
    <link href="../../assets/js/fullcalendar/fullcalendar.css" rel="stylesheet" />

    <%-- <link href="../../assets/js/plugins/fullcalendar/fullcalendar.css" rel="stylesheet" />--%>
    <link href="../../assets/js/fullcalendar/styles.css" rel="stylesheet" />

    <script src="https://d3js.org/d3.v3.min.js" charset="utf-8"></script>
        <style type="text/css" src="gauge.css">
  		 
              .chart-gauge {
    width: 400px;
    margin: auto auto;
}
			.chart-first
			{
				 fill: #FB3033;
			}
			.chart-second
			{
				fill: #F2BA3A;
			}
            .chart-third
            {
                fill: #9FBD35;
               
            }
		
			.needle, .needle-center
			{
				fill: #000000;
			}
            .text {
                color: "#112864";
                font-size: 16px;
            }
            

			svg {
			  font: 10px sans-serif;
              height:215px;
			}
            

		</style>





</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">




    <div class="content">

       

        <div class="  ml-30 mr-30 mt-15">
            <div class="row gutters-tiny">

             
                <!-- Row #4 -->
                <div class="col-md-6 col-xl-3">
                    <a href="../../task/activities/running.aspx" class="block block-transparent" href="javascript:void(0)">
                        <div class="block-content block-content-full bg-primary">
                            <div class="py-50 text-center bg-black-op-10">
                                <div class="mb-20">
                                            <i class="fa fa-gear fa-spin fa-2x text-white"></i>
                                        </div>
                                <div class="font-size-h2 font-w700 mb-0 text-white"><%=inprocessscedule %></div>
                                <div class="font-size-sm font-w600 text-uppercase text-white-op">Running Jobs</div>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="col-md-6 col-xl-3">
                    <a href="../../task/activities/pending.aspx" class="block block-transparent" href="javascript:void(0)">
                        <div class="block-content block-content-full bg-gd-sun">
                            <div class="py-50 text-center bg-black-op-10">
                                   <div class="mb-20">
                                            <i class="fa fa-gear fa-spin fa-2x text-white"></i>
                                        </div>
                                <div class="font-size-h2 font-w700 mb-0 text-white"><%=pendingwork %></div>
                                <div class="font-size-sm font-w600 text-uppercase text-white-op">Pending Jobs</div>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="col-md-6 col-xl-3">
                    <a href="../../task/activities/completed.aspx" class="block block-transparent" href="javascript:void(0)">
                        <div class="block-content block-content-full text-right bg-green">
                            <div class="py-50 text-center bg-black-op-25">
                                <div class="mb-20">
                                            <i class="fa fa-gear fa-spin fa-2x text-white"></i>
                                        </div>
                                <div class="font-size-h2 font-w700 mb-0 text-white"><%=completedschedule %></div>
                                <div class="font-size-sm font-w600 text-uppercase text-white-op">Completed Schedule</div>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="col-md-6 col-xl-3">

                    <a  href="../../task/schedule/pending.aspx" class="block block-transparent" href="javascript:void(0)">
                        <div class="block-content block-content-full text-right bg-gd-aqua">
                            <div class="py-50 text-center bg-black-op-25">
                                <div class="mb-20">
                                            <i class="fa fa-wrench fa-2x text-white"></i>
                                        </div>
                                <div class="font-size-h2 font-w700 mb-0 text-white"><%=schedule %></div>
                                <div class="font-size-sm font-w600 text-uppercase text-white-op">Pending Schedule</div>
                            </div>
                        </div>
                    </a>
                </div>
                <!-- END Row #4 -->
                     <div class="col-xl-6" >
                                  
                                    <div class="block">
            <div class="block-header block-header-default">
                <h3 class="block-title">Quickly Check Your Job Status</h3>
                <div class="block-options">

                <div class="col-md-12">
                    
                                      <asp:Label ID="lblproj" runat="server" Text="Select Job Code" CssClass="form-group"></asp:Label>
                                   <asp:DropDownList ID="drdjobcode" AppendDataBoundItems="True"  AutoPostBack="True" OnSelectedIndexChanged="drdjobcode_SelectedIndexChanged"  runat="server" CssClass="js-select2 form-control" DataSourceID="SqlDataSource1" DataTextField="Jobcode" DataValueField="Jobcode">
                                         <asp:ListItem Text="Please select" Value="" />
                                   </asp:DropDownList>
                                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Jobcode] FROM [schedule]"></asp:SqlDataSource>
                               
                        
               


                         </div>
                       

                </div>
                       
            </div>
            <div class="block-content block-content-full" >

                


                  <div class="table-responsive">
                              <div class="chart-gauge"></div>
                        </div>


                </div>
                                        </div>
                                   </div>


                       
                               

        <div class="col-md-6">
                            <div class="row invisible" data-toggle="appear">
                        <!-- Row #4 -->
                        <div class="col-md-12">
                            <div class="block block-link-shadow overflow-hidden" href="javascript:void(0)">
                                <div class="block-content block-content-full">
                                    <i class="si si-briefcase fa-2x text-body-bg-dark"></i>
                                    <div class="row gutters-tiny">
                                            <div class="col-4">
                            <div class="block block-transparent bg-primary">
                                <div class="block-content block-content-full">
                                    <div class="py-05 text-center">
                                        <div class="mb-20">
                                            <i class="fa fa-gears fa-2x text-primary-light"></i>
                                        </div>
                                        <div class="font-size-h4 font-w600 text-white">Running Activities</div>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-4">
                            <div class="block block-transparent bg-warning">
                                <div class="block-content block-content-full">
                                    <div class="py-05 text-center">
                                        <div class="mb-20">
                                            <i class="fa fa-clock-o fa-2x text-info-light"></i>
                                        </div>
                                        <div class="font-size-h4 font-w600 text-white">Pending Activities</div>
                                       
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-4">
                            <div class="block block-transparent bg-success">
                                <div class="block-content block-content-full">
                                    <div class="py-05 text-center">
                                        <div class="mb-20">
                                            <i class="fa fa-check fa-2x text-success-light"></i>
                                        </div>
                                        <div class="font-size-h4 font-w600 text-white">Completed Activities</div>
                                       
                                      
                                    </div>
                                </div>
                            </div>
                        </div>
                                    </div>
                                    <div class="row py-20">
                                        <div class="col-6 text-right border-r">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInLeft">
                                       
                                                <i class="fa fa-user fa-2x text-info"></i> <div class="font-size-h3 font-w600 text-info"><%=site %></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Customer</div>
                                            </div>
                                        </div>
                                        <div class="col-6">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInRight">
                                                 <i class="fa fa-users fa-2x text-green-acid"></i> <div class="font-size-h3 font-w600 text-success"><%=emp %></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Employee</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        
                        <!-- END Row #4 -->
                    </div>
                        </div>


                
            </div>
        </div>
        

        

           <%-- <div class="clearfix"></div>--%>
                         
        
        <div class="block ml-30 mr-30 mt-15">
            <div class="block-header block-header-default">
                <h3 class="block-title">Pending &nbsp; Job</h3>
                <div class="block-options">
                </div>
            </div>
            <div class="block-content block-content-full text-center">
                <div class="row mr-6 ml-6 mt-6 ">
                    <div class="block-content block block-link-shadow">

                        <div class="table-responsive">
                            <%=data%>
                        </div>



                    </div>

                </div>
            </div>
        </div>
        
         


           <%--<div class="row">
                       
                         <div class="col-xl-6">

                                    <div class="block">
            <div class="block-header block-header-default">
                <h3 class="block-title">Attendance</h3>
                <div class="block-options">
                </div>
            </div>
            <div class="block-content block-content-full text-center">
                <!-- Bars Chart Container -->
                <canvas class="js-chartjs-bars"></canvas>
            </div>
                                        </div>
        </div>      
               </div>--%>


     
        <div class="block ml-30 mr-30 mt-15">
            <div class="block-header block-header-default">
                <h3 class="block-title">Calendar <small>Events</small></h3>
                <div class="block-options">
                </div>
            </div>
            <div class="block-content block-content-full text-center">
                <!-- Bars Chart Container -->

                <div class="block-content">
                    <div class="table-responsive">
                        <div id='calendar2'></div>

                    </div>

                </div>

            </div>
        </div>







        
        </div>
                    <!-- Contextual -->
                    




    <script>
        // initialize the calendar on index page
        var date2 = new Date();
        var ddd = date2.getDate();
        var mmm = date2.getMonth();
        var yyy = date2.getFullYear();


        if ($('#calendar2').length) {
            $('#calendar2').fullCalendar({
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,basicWeek,basicDay'
                },
                editable: true,
                events: [

                   <%=calandar%>]
            });
        }

    </script>


   
    <script>

        // data which need to be fetched

       // var name = "Job Status";

        var value = [<%=pending%>];


        var gaugeMaxValue = 100;

        // données à calculer 
        var percentValue = value / gaugeMaxValue;

        ////////////////////////

        var needleClient;



        (function () {

            var barWidth, chart, chartInset, degToRad, repaintGauge,
                height, margin, numSections, padRad, percToDeg, percToRad,
                percent, radius, sectionIndx, svg, totalPercent, width;



            percent = percentValue;

            numSections = 1;
            sectionPerc = 1 / numSections / 2;
            padRad = 0.025;
            chartInset = 10;

            // Orientation of gauge:
            totalPercent = .75;

            el = d3.select('.chart-gauge');

            margin = {
                top: 20,
                right: 20,
                bottom: 30,
                left: 20
            };

            width = el[0][0].offsetWidth - margin.left - margin.right;
            height = width;
            radius = Math.min(width, height) / 2;
            barWidth = 40 * width / 300;



            //Utility methods 

            percToDeg = function (perc) {
                return perc * 360;
            };

            percToRad = function (perc) {
                return degToRad(percToDeg(perc));
            };

            degToRad = function (deg) {
                return deg * Math.PI / 180;
            };

            // Create SVG element
            svg = el.append('svg').attr('width', width + margin.left + margin.right).attr('height', height + margin.top + margin.bottom);

            // Add layer for the panel
            chart = svg.append('g').attr('transform', "translate(" + ((width + margin.left) / 2) + ", " + ((height + margin.top) / 2) + ")");


            chart.append('path').attr('class', "arc chart-first");
            chart.append('path').attr('class', "arc chart-second");
            chart.append('path').attr('class', "arc chart-third");


            arc3 = d3.svg.arc().outerRadius(radius - chartInset).innerRadius(radius - chartInset - barWidth)
            arc2 = d3.svg.arc().outerRadius(radius - chartInset).innerRadius(radius - chartInset - barWidth)
            arc1 = d3.svg.arc().outerRadius(radius - chartInset).innerRadius(radius - chartInset - barWidth)

            repaintGauge = function () {
                perc = 0.5;
                var next_start = totalPercent;
                arcStartRad = percToRad(next_start);
                arcEndRad = arcStartRad + percToRad(perc / 3);
                next_start += perc / 3;


                arc1.startAngle(arcStartRad).endAngle(arcEndRad);

                arcStartRad = percToRad(next_start);
                arcEndRad = arcStartRad + percToRad(perc / 3);
                next_start += perc / 3;

                arc2.startAngle(arcStartRad + padRad).endAngle(arcEndRad);

                arcStartRad = percToRad(next_start);
                arcEndRad = arcStartRad + percToRad(perc / 3);

                arc3.startAngle(arcStartRad + padRad).endAngle(arcEndRad);

                chart.select(".chart-first").attr('d', arc1);
                chart.select(".chart-second").attr('d', arc2);
                chart.select(".chart-third").attr('d', arc3);


            }
            /////////

            var dataset = [{ metric: name, value: value }]

            var texts = svg.selectAll("text")
                        .data(dataset)
                        .enter();

            texts.append("text")
                 .text(function () {
                     return dataset[0].metric;
                 })
                 .attr('id', "Name")
                 .attr('transform', "translate(" + ((width + margin.left) / 6) + ", " + ((height + margin.top) / 1.5) + ")")
                 .attr("font-size", 25)
                 .style("fill", "#000000");


            var trX = 180 - 210 * Math.cos(percToRad(percent / 2));
            var trY = 195 - 210 * Math.sin(percToRad(percent / 2));
            // (180, 195) are the coordinates of the center of the gauge.

            displayValue = function () {
                texts.append("text")
                    .text(function () {
                        return dataset[0].value;
                    })
                    .attr('id', "Value")
                    .attr('transform', "translate(" + trX + ", " + trY + ")")
                    .attr("font-size", 18)
                    .style("fill", '#000000');
            }



            texts.append("text")
                .text(function () {
                    return 0;
                })
                .attr('id', 'scale0')
                .attr('transform', "translate(" + ((width + margin.left) / 100) + ", " + ((height + margin.top) / 2) + ")")
                .attr("font-size", 15)
                .style("fill", "#000000");

            texts.append("text")
                .text(function () {
                    return gaugeMaxValue / 2;
                })
                .attr('id', 'scale10')
                .attr('transform', "translate(" + ((width + margin.left) / 2.15) + ", " + ((height + margin.top) / 30) + ")")
                .attr("font-size", 15)
                .style("fill", "#000000");


            texts.append("text")
                .text(function () {
                    return gaugeMaxValue;
                })
                .attr('id', 'scale20')
                .attr('transform', "translate(" + ((width + margin.left) / 1.03) + ", " + ((height + margin.top) / 2) + ")")
                .attr("font-size", 15)
                .style("fill", "#000000");

            var Needle = (function () {

                //Helper function that returns the `d` value for moving the needle
                var recalcPointerPos = function (perc) {
                    var centerX, centerY, leftX, leftY, rightX, rightY, thetaRad, topX, topY;
                    thetaRad = percToRad(perc / 2);
                    centerX = 0;
                    centerY = 0;
                    topX = centerX - this.len * Math.cos(thetaRad);
                    topY = centerY - this.len * Math.sin(thetaRad);
                    leftX = centerX - this.radius * Math.cos(thetaRad - Math.PI / 2);
                    leftY = centerY - this.radius * Math.sin(thetaRad - Math.PI / 2);
                    rightX = centerX - this.radius * Math.cos(thetaRad + Math.PI / 2);
                    rightY = centerY - this.radius * Math.sin(thetaRad + Math.PI / 2);


                    return "M " + leftX + " " + leftY + " L " + topX + " " + topY + " L " + rightX + " " + rightY;




                };

                function Needle(el) {
                    this.el = el;
                    this.len = width / 2.5;
                    this.radius = this.len / 8;
                }

                Needle.prototype.render = function () {
                    this.el.append('circle').attr('class', 'needle-center').attr('cx', 0).attr('cy', 0).attr('r', this.radius);




                    return this.el.append('path').attr('class', 'needle').attr('id', 'client-needle').attr('d', recalcPointerPos.call(this, 0));


                };

                Needle.prototype.moveTo = function (perc) {
                    var self,
                        oldValue = this.perc || 0;

                    this.perc = perc;
                    self = this;

                    // Reset pointer position
                    this.el.transition().delay(100).ease('quad').duration(200).select('.needle').tween('reset-progress', function () {
                        return function (percentOfPercent) {
                            var progress = (1 - percentOfPercent) * oldValue;




                            repaintGauge(progress);
                            return d3.select(this).attr('d', recalcPointerPos.call(self, progress));
                        };
                    });

                    this.el.transition().delay(300).ease('bounce').duration(1500).select('.needle').tween('progress', function () {
                        return function (percentOfPercent) {
                            var progress = percentOfPercent * perc;

                            repaintGauge(progress);
                            return d3.select(this).attr('d', recalcPointerPos.call(self, progress));
                        };
                    });

                };


                return Needle;

            })();



            needle = new Needle(chart);
            needle.render();
            needle.moveTo(percent);

            setTimeout(displayValue, 1350);



        })();
    </script>
 <%--   <script>
        a = jQuery(".js-chartjs-donut"),
n = {
    labels: ["abc", "d", "Tickets"],
    datasets: [{
        data: [50, 40, 10],
        backgroundColor: ["rgba(156,204,101,1)", "rgba(255,202,40,1)", "rgba(239,83,80,1)"],
        hoverBackgroundColor: ["rgba(156,204,101,.5)", "rgba(255,202,40,.5)", "rgba(239,83,80,.5)"]
    }]
};
        a.length && new Chart(a, {
            type: "doughnut",
            data: n
        })

    </script>
   --%>


</asp:Content>

