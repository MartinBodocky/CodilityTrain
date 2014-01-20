-module(tapeequilibrium).
-compile(export_all).

%% details: http://codility.com/demo/results/demoYYAYG7-KP9/

bList() -> [crypto:rand_uniform(-1000, 1000) || _ <- lists:seq(1, 10000)].
sList() -> [-3,1,-2,4,-3].

first({X,_,_}) -> X.

foldStep(Elem,{A,S1,S2}) ->
	TmpSum1 = S1 + Elem,
	TmpSum2 = S2 - Elem,
	Abs = abs(TmpSum2- TmpSum1),
	Ret = case Abs < A of
			true -> {Abs,TmpSum1,TmpSum2};
			false -> {A, TmpSum1, TmpSum2}
		end,
	Ret.

solution(A) ->
	Res = 134217728, %% Biggest small integer
	Sum = lists:sum(A),
	Return = lists:foldl(fun foldStep/2, {Res,0,Sum}, A),
	first(Return).
	
sExample() -> solution(sList()).
bExample() -> solution(bList()).