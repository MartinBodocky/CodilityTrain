-module(frogjmp).
-compile(export_all).

%% details: http://codility.com/demo/results/demoJYANDY-QFY/

solution(X,Y,D) when X < Y -> 
	Distance = Y - X,
	Steps = Distance div D,
	Res = case Distance rem D of
		0 -> Steps;	
		_ -> Steps + 1 
		end,
	Res;
solution(_,_,_) -> 0.

example() -> solution(10,85,30).