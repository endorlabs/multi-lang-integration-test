ThisBuild / scalaVersion := "3.3.1"
ThisBuild / organization := "the.whatever.org"

lazy val app = project
  .in(file("."))
  .settings(
    name := "the app",
    libraryDependencies += "org.scala-lang" %% "toolkit" % "0.1.7",
    libraryDependencies += "org.apache.commons" % "commons-text" % "1.9"
  )
  .aggregate(corelib)
  .aggregate(supplementlib)

lazy val corelib = project
  .in(file("lib"))
  .settings(
    name := "the core lib",
    libraryDependencies += "org.apache.derby" % "derby" % "10.4.1.3",
    libraryDependencies += "org.scala-lang" % "scala-testkit" % "2.13.12",
    libraryDependencies += "org.webpieces.server" % "http-router" % "2.1.109" % "runtime"
  )

lazy val supplementlib = project
  .in(file("otherlib"))
  .settings(
    name := "the supplement lib",
    libraryDependencies += "org.apache.derby" % "derbyclient" % "10.4.1.3",
    libraryDependencies += "org.scala-lang" % "jline" % "2.10.7",
    libraryDependencies += "org.scala-lang" % "scala-parser-combinators" % "2.11.0-M4",
    libraryDependencies += "joda-time" % "joda-time" % "2.10.6",
    //libraryDependencies += "org.webpieces.server.plugin" % "plugin-hibernate" % "2.1.109"
  )

lazy val standalone = project
  .in(file("tool"))
