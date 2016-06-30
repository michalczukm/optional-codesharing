// https://docs.oracle.com/javase/8/docs/api/java/util/Optional.html
try
{
    /* empty */
    Optional emptyOptional = Optional.empty();
    System.out.println( emptyOptional.get() );
}
catch( NoSuchElementException ex )
{
    System.out.println( "expected NoSuchElementException" ); //this is executed
}







Optional stringToUse = Optional.of( "optional is there" );
if( stringToUse.isPresent() )
{
	System.out.println( stringToUse.get() );
}	








Optional stringToUse = Optional.of( "optional is there" );
stringToUse.ifPresent( System.out::println );







// if the value is not present
Optional carOptionalEmpty = Optional.empty();
carOptionalEmpty.filter( x -> "250".equals( x.getPrice() ) ).ifPresent( x -> System.out.println( x.getPrice() + " is ok!" ) );

// if the value does not pass the filter
Optional carOptionalExpensive = Optional.of( new Car( "3333" ) );
carOptionalExpensive.filter( x -> "250".equals( x.getPrice() ) ).ifPresent( x -> System.out.println( x.getPrice() + " is ok!" ) );

// if the value is present and does pass the filter
Optional carOptionalOk = Optional.of( new Car( "250" ) );
carOptionalOk.filter( x -> "250".equals( x.getPrice() ) ).ifPresent( x -> System.out.println( x.getPrice() + " is ok!" ) );