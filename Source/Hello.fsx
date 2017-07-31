#r "../packages/iTextSharp/lib/itextsharp.dll"

open iTextSharp.text
open iTextSharp.text.pdf

let write = new PdfWriter("hello.pdf")
let doc = new PdfDocument(writer)
doc.Add(Paragraph("Hello, wrold!"))
