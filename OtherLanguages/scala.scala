case class User(
  id: Int,
  firstName: String,
  lastName: String,
  age: Int,
  gender: Option[String])

object UserRepository {
  private val users = Map(1 -> User(1, "John", "Doe", 32, Some("male")),
                          2 -> User(2, "Johanna", "Doe", 30, None))
  def findById(id: Int): Option[User] = users.get(id)
  def findAll = users.values
}








// get the value
val user1 = UserRepository.findById(1)
if (user1.isDefined) {
  println(user1.get.firstName)
} // will print "John"









// map the vale
val gender1 = UserRepository.findById(1).flatMap(_.gender) // gender is Some("male")
val gender2 = UserRepository.findById(2).flatMap(_.gender) // gender is None
val gender3 = UserRepository.findById(3).flatMap(_.gender) // gender is None