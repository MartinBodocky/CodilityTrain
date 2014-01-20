-module(permmissingelem).
-compile(export_all).

%% details: http://codility.com/demo/results/demoZMT7D9-DFA/

bigList() -> [ N +1 || N <-lists:seq(1,100000)].
smallList() -> [ 1,3,2,5,6,7,8,4,10 ].

solution(A) ->
	Sum = (length(A)+1)*(length(A)+2) div 2,
	SumList = lists:sum(A),
	Sum - SumList.

bExample() -> solution(bigList()).
sExample() -> solution(smallList()).