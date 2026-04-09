using System;
// Value type — struct lives on the STACK
// Each assignment creates a fully independent copy
struct Soul { public int Power; }

// Reference type — class lives on the HEAP
// Assignment just copies the pointer (both variables share one object)
class Vessel { public int Power; }

Soul s1 = new Soul { Power = 100; };
Soul s2 = s1; // COPY — s2 is its own chunk of memory, Gojo with Infinity

Vessel v1 = new Vessel { Power = 100 };
Vessel v2 = v1; // REFERENCE — v2 points at the SAME object as v1, Yuji/Sukuna

s2.Power = 999; // only mutates s2's copy, s1 is untouched
v2.Power = 999;    // mutates the shared object — v1 FEELS this
