```
Professional Internship Report
Shanghai GES Information Technology Co. Ltd (Venture Corporation Limited)
```
```
PREPARED BY:
KOH NGUAN THENG, MELVYN
U1521083K
Computer Engineering
```

## Table of Contents

- Abstract
- Acknowledgement
- Chapter 1: Introduction
- Chapter 2: Main Report
- Chapter 3: Summary and Conclusion
- Appendices
- References


## Abstract

The purpose of this report is to concisely review the 20-week Professional Internship spent with
Shanghai GES Information Technology Co. Ltd, providing insights on working with the Chinese
employees on a few projects.

The report will record more notably, the company and team structure, the cultural and language
barriers at work and how those challenges were overcome. It is important to mention that this
report shall put less focus on the actual weekly assignment, project details and product
specifications due to its sensitive and non-disclosure nature for a competitive firm.

In contrast, this report will be anchored on the Computer Science and Engineering concepts that
was educated within the 20 weeks to seek to relate as well as to compare these concepts to those
that was taught in School.


## Acknowledgement

I would like to express my special thanks of gratitude to my immediate Supervisor, Mr. Wu Cheng
Bo, who is the Operations Manager, for his responsible and encouraging role in allowing me to
engage actively with the colleagues in the department despite knowing that our lack of some
technical skills will hamper the project timeline. I would also like to thank the Human Resource
personnel, Ms. Jing Jing, for being very inclusive and friendly throughout, and for bringing me for
team building meals that ensured we felt appreciated and included in the team despite the
apparent racial and cultural differences.

Additionally, I want to give special mention to Operations Department for their professionalism
and excellence in imparting knowledge and their personal experiences with Career choices.
Finally, I would like to express my sincere gratitude to the Mr. Zhao Qian for his tireless effort
into guiding me directly, engaging me on their infrastructure knowledge and for patiently
answering my queries. This experience cannot be made any better without these people as they
collectively provide an informative platform for an engineering student with no industrial
experience.


## Chapter 1: Introduction

Company Background

Venture Corporation was founded in 1984 as a global player in many various electronics services
like providing hardware and software solutions. Shanghai GES Information Technology Co. Ltd
was founded as a subsidiary of Venture Corporation and its focus was on design for
manufacturability supply chain management, as well as product refurbishment and technical
support across a range of high-mix, high-value and complex products.

Venture Corporation is headquartered in Singapore with more than 12,000 employees worldwide
including South-East Asia, East Asia, America and Europe.

Mission of the company:
To be a leading global provider of technology services, products and solutions.

Core Values of the company:

- Relentless pursuit of excellence
- Rendering the highest level of total customer satisfaction
- Encouraging employees to realize their full potential
- Building strong cohesion and teamwork
- Fostering creativity and innovation

The rare opportunity to work with a dedicated team overseas on an industrial project will shed
light on the team structure, management philosophy and the engineering concepts that are
applicable to the industry. In addition to that, interns are positively engaged to learn, to suggest
and explore the solutions given for the project’s specifications.

The chance to be employed in an MNC has given me a global exposure in terms of working with
vast nationalities on overseas projects while amalgamating cultural differences and overcoming
language barriers into working towards the same aim.


## Chapter 2: Main Report

**2.1 Inventory Management (Windows Form Application 1)**

Problem

The employees have been using paper and pens to keep track on the many thousands of
hardware products for their clients, and each hardware product is under a machine model (a
machine model has many hardware devices). There are many machine models in the factory. The
lists are not exhaustive as there are many new and existing clients. Whenever there is a new
order, they must print out the product list for inventory tracking (Figure 1).

```
Figure 1: Photo of a Physical Product List
```
Over time, it is not unusual that the list might be misplaced or damaged due to the mishandling
of the factory workers considering that there are thousands of such files in the factory. On a daily
basis, there are many items to be tracked and each item has its own unique code. The unique
codes (Part Numbers) are complexed and might look similar from one another.


Planning

Before getting my hands on the codes, planning of the development of the software application
was crucial. After several meetings with my team, we came up with a concrete plan.

A brief infrastructure of our software application during one of the meetings:

```
Figure 2: Brief Infrastructure
```
We all had quite a few differing opinions on the infrastructure. The main conflicting view was the
implementation of a database. The existing Excel sheets that the employees used are meant for
humans to read and not for the computers to read. There are various formats of the Excel sheets
as the contents in each cell are hand-typed, leading to a lack of consistency when it comes to
formats. Hence, I proposed that we could have an SQL database as that would be easier for the
windows form application to read the data rather than selectively reading cells in the Excel
sheets. However, the implementation of SQL could pose a problem – it requires maintenance
work in future. Because the Operations Department does not have any IT teams, they cannot
afford to have maintenance work when my internship ends.

This forced me to come up with a very careful planning in the software development process.


Execution

A small extract of one of their product lists on Excel sheet:

```
Figure 3: Extract of Product List (Highlighted are Part Numbers)
```
Their lists are displayed on Excel sheets and documents have multiple sheets/pages of products.
Judging by the complexity of the list, it is not very user-friendly. Whenever an inventory tracking
takes place, which must be done twice daily, employees would have to search for the physical
files based on the Machine Model number, and in that file, are multiple pages of product lists (as
shown in Figure 2). It is not uncommon if goods happen to be unaccounted for, or were
misunderstood as the other goods due to the similarities of the part numbers (as highlighted in
the Figure 1). All these human errors are quite common especially when the employees work
long hours.

To improve the efficiency of this workload, the Operations Department decided to have a
customized inventory software. The purpose of the Windows Form Application that I have built
is to serve as an Application Programming Interface (API), making inventory management a much
easier and less error-prone job.


All they have to do now is to open the Windows Application, enter the Machine Number or
Client’s name, grab a barcode scanner, and scan the barcode on the product. All these save the
employees a lot of time and making the operations in the factory much more efficient (see
Appendix A).

_Figure 4: Screenshot of Windows Form App 1_
The ones in green are the products that have already been scanned with a barcode scanner, and
the “Quantity Check” shows the number of items that have been scanned and the ones in grey
are the ones that are yet to be scanned (See Appendix B for demonstration).

The Windows Form Application was built solely on C-sharp (C#) on Microsoft Visual Studio.
Initially I faced a lot of difficulties as I had limited knowledge on the C# language. However, I was
fortunate that I had prior knowledge on Object-oriented design principles, a course that I have
undertaken in my Year 2 of Computer Engineering.

```
User enters the Machine
Number/Client’s name or simply
choose from the drop-down list
```
```
User scans the barcode on the item,
and the application receives the
item’s Part Number and searches on
the grid view
```

I made use of the free courses on Lynda.com on building Windows Form Applications with Visual
C#. The whole process took about 2 weeks for me understand the language more as well as
writing my own codes for experimentation. And by the 5th week of my internship, I had my
application on a live test run in the factory. There were many bugs and errors in the beginning as
there are tons of Excel files with various formats or versions. I managed to debug them by the 7th
week, thanks to the help of my colleagues who were very patient in helping me find the root of
the problems.

There were so many bugs that were not easily traceable using the debugging tools provided by
Visual Studio. Tracing of the software bugs took me several hours a day to figure out, if not it
could take up the whole day just to fix a bug. For example, I could take hours and hours thinking
that my algorithms for selective extraction of data in cells are the cause of the problem, but after
taking a break and looking at the whole project again, I began to realize the real problem was the
string connection between my C# project and Excel (namely the _OleDbConnection_ ). Specific string
connections must be used for different versions of Excel. Some Excel files that the company uses
are earlier than 2007 while some are 20007 or later.

For earlier than 2007:

_conn=@"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended
Properties='Excel 8.0;HRD=Yes;IMEX=1';";_

For 2007 or later:

_conn=@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended
Properties='Excel 12.0;HDR=YES';";_

The biggest challenge in this project was the development phase. The data the application
receives comes from Microsoft Excel sheets that are meant to be just human-readable, and not
meant for Data Grid View used in Windows Form technology. The Windows Form Application
that I built must be smart enough to handle what data to be read and what to ignore. Hence, I
had to come out with algorithms that could catch whatever cells that are necessary to be


recorded in the Data Grid View. It was very tedious coming up with complex algorithms, given
that there are so many exceptions and possible conditions.

The second biggest challenge I faced was to build an application that must be extremely user-
friendly. The reason is that most of the users of this software application are factory workers who
do not have educational backgrounds. Educating the workers was not easy as most of them, or if
not all, are used to using papers and pens and have never interacted with a PC. It was not easy
explaining to them on how to use the application and what kind of software issues they might
face. Hence, I found a way to come up with an algorithm that works – the application can self-
debug if it ever encounters an Excel sheet that has a different format (see Appendix Figure 8).

After close to 8-9 weeks of sheer hard work and diligence, the Windows Form Application was
fully-implemented into the factory. Occasionally, there were still errors encountered by the
factory workers as they were utilizing the software as it encountered a different type of Excel
format.

By the end of Week 11, the first Windows Form Application was officially completed.


**2.2 Verification Before Export (Windows Form Application 2)**

As soon as the first API was completed for execution, the second project began to kick in. The
outlook of the application looks quite similar in terms of the functionality as it also involves
scanning of barcodes and getting an output. Instead of scanning barcodes for Part Number and
search if it exists on the list, this application serves as a verification of products in the product list
before it is being exported to the clients.

User is required to scan 2 barcodes:

1. Table Number + Reel + Side (as ‘First Scan’)
2. Part Number (as ‘Second Scan’)

_Figure 5: Screenshot of Windows Form Application 2_
The first scan tells the application the location of the disk, more specifically, the exact location
within the machine where the disk is placed. The second scan informs the application that the
identification of the disk through a Part Number, and the system will verify if the disk is in the
correct location or not.


## Chapter 3: Summary and Conclusion

My internship was undoubtedly an enriching learning journey. I had a great opportunity of
undertaking a 20-week overseas internship in Shanghai. This internship provided me with many
opportunities to develop both my soft skills and technical competencies.

The team I work with was from the Operations Department. As I never expected myself to work
with a team that have no IT or programming backgrounds, I had to learn everything on my own
when it comes to the technical aspects in building the software applications. Furthermore, there
is a lot of restrictions and filtering of the web when it comes to finding answers on the World
Wide Web. The Great Firewall of China crippled my research progress at the start but over time,
I learnt how to overcome all those difficulties.

There were times when I had difficulties explaining in layman terms instead of the usual technical
terms we use in Computer Science and Engineering.

I get to learn much about the various enterprise practices in operational management and had
the hands-on opportunity to participate in this real-life application. These experiences offered
me perspectives from the corporate angle, which differs very much from the theoretical
knowledge gleaned from school. Hence, I found the exposure extremely rewarding.

Overall, I enjoyed my professional internship with Shanghai GES Information Technology
(Venture Corporation) as it exposed me to new perspectives that cannot be found within the
confines of an academic program in school, and I thank my immediate supervisor for taking time
in guiding me through my 20 weeks of journey here.


## Appendices

```
Appendix A
```
```
Figure 6: Employees utilizing the Windows Form Apps
```

```
Appendix B
```
Select the folder from server where the Excel file stored

```
The application identifies all Excel files in the
selected folder and returns a drop-down list
```

User scans barcode (Part Number) and dynamically,
the Data Grid View shows if it’s on the system or not

```
The application returns the data into
its own Data Grid View (in grey)
```
```
Displays the information of the disc
```

After a barcode scan, and part number identified
by the system, it returns a result where green
means successful

```
In every successive scan, a time stamp is
returned to show when the disc was
scanned. This is essential as a form of receipt
```
```
When everything is done, user can
output the result of the scans to an
Excel file as a form of record
```

```
Appendix C
```
_Figure 7: Algorithm to select the cells on Excel sheets (segment 1)_


_Figure 8: Algorithm to select the cells on Excel sheets (segment 2)_


```
Appendix D
```
_Figure 9: Methods for self-debugging if it encounters a different Excel sheet format_


## References

1. [http://www.venture.com.sg/about/profile.html](http://www.venture.com.sg/about/profile.html)


