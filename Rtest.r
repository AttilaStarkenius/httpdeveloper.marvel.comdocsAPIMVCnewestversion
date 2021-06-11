Import System.Runtime.InteropServices

' In SDK-style projects such as this one, several assembly attributes that were historically
' defined in this file are now automatically added during build and populated with
' values defined in project properties. For details of which attributes are included
' and how to customise this process see: https://aka.ms/assembly-info-properties


' Setting ComVisible to false makes the types in this assembly not visible to COM
' components.  If you need to access a type in this assembly from COM, set the ComVisible
' attribute to true on that type.

<Assembly: ComVisible(False)> 

' The following GUID is for
    the ID of the typelib if this project is exposed to COM.

< Assembly:Guid("937ef4a4-e492-4114-8359-295a999d8019") >
    library(ggplot2)
library(reshape)
library(vegan)

input_file <- "data/data.csv"
output_file <- "data/results.csv"

# read input
input_data <- read.csv(input_file)
# get number of samples in data
sample_number <- nrow(input_data)
# generate results
results <- some_other_function(input_file, sample_number)
# write results
write.table(results, output_file)