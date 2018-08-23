
type Sandwich() =
    abstract Ingredients : string list
    abstract Calories : int

    default this.Ingredients  = []
    default this.Calories = 0

type BltSandwich () =
    inherit Sandwich()

    override this.Ingredients = ["Bacon"; "Lettuce"; "Tomato"]
    override this.Calories = 330

type TurkeySwissSandwich() =
    inherit Sandwich()

    override this.Ingredients = ["Turkey"; "Swiss"]
    override this.Calories = 330

[<Sealed>]
type BltWithPiclesSandwich() =
    inherit BltSandwich()

    override this.Ingredients = "Pickles"::base.Ingredients
    override this.Calories = 50 + base.Calories

// UpCast
let sandwithWithPicles = new BltWithPiclesSandwich();
let sandwich = sandwithWithPicles :> Sandwich
// DynamicCast (or downcast :D)
let thenSandwichWithPiclesAgain = sandwich :?> BltWithPiclesSandwich
