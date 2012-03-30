// Learn more about F# at http://fsharp.net

namespace HDNMeetup
open System
open System.IO


module FinaryChopper =

   let rec recChop (searchingFor, searchingIn) =
           let searchArray = searchingIn|>Seq.toArray
           let mid = searchArray.Length/2
           if (searchArray.[mid] > searchingFor) then
             -3
           else
             -4
//             let result = recChop(searchingFor, searchingIn|>Seq.takeWhile(fun elem -> elem > searchingFor))
//             if result < 0 then
//                result 
//             else
//                mid + result

   let Chop (searchingFor, searchingIn:int[]) = 
       match searchingIn|>Array.toList with
        | [] -> -1
        | _ -> recChop (searchingFor, searchingIn)