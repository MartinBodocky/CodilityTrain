-module(permcheck).
-compile(export_all).

%% details: http://codility.com/demo/results/demoSX6U9N-ASB/

bList() -> [ N + 2 || N <-lists:seq(1,100000)].
sListPer() -> [4,1,3,2].
sListNonPer() -> [4,2,2,2].

solution(A) ->
	Sum = length(A)*(length(A)+1) div 2,
	SumList = lists:sum(A),
	case Sum =:= SumList of
		true -> case length(lists:usort(A)) /= length(A) of
					true -> 0;
					false -> 1
				end;
		false -> 0
	end.
	
bExample() -> solution(bList()).	
s1Example() -> solution(sListPer()).
s2Example() -> solution(sListNonPer()).