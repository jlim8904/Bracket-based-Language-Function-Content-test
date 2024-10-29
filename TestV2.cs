class Test {
  public test1() {
    const a = 1;
    
    const b = "{\"";

    const c = 1; // {{{{}{{{{}{}}}{{{{{}

    const d = 1;
  }
  
  public test2() {
    /*
    {{{{{}}{{{{{{}}}}}}}}}}}}}{{{{{{{{{}}{
    */
    const a = 1;
    
    const b = `}"`;

    const c = '{';

    const d = 1;
  }
  
  public test3() {
    const a = 1;
    
    const b = `}"`;

    const c = "fdgcfd\
      \"dsadasd{{}\
    asdasdasd";

    const d = 1;
  }
  
  public test4() {
    const a = 1;
    
    const b;

    const c = '{';

    const d = 1;
  }
}
