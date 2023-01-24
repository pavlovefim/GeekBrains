string = 'This is a simple test message for test'
string2 = 'test'
pattern1 = 'test$'
pattern2 = '^test'
pattern3 = '^test$'
re.search(pattern1, string) is None      
False
re.match(pattern2, string) is None
True                                 
re.match(pattern3, string) is None
True                                
re.match(pattern3, string2) is None
False