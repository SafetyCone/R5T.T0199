# R5T.T0199
Common, root, location-anonymous, strongly-typed types. (A catch-all for strong-types that have no other clear home.)

Root strong-typed types are those types that inherit from no other strong-typed interfaces.
=> In this library, an exception is made for those types that inherit from types in this library.

Location-anonymous means that the type can live in an anonymous namespace, like R5T.N0003 (which is the default for strongly-typed types), instead of a location-aware namespace, like R5T.T0199 (which will be required to change in all downstream client files if the location is ever changed).
=> In this library, an exception is made for types that you may want to be location-aware (due to possible name collisions).
=> Additionally, sub-namespaces (N###) are allowed for things like IYear, that might be an integer, DateTime, or string.