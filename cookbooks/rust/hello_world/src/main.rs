extern crate rand;

use std::rand::random;

fn main() {
    println!("Welcome to password generator!");

    // Site
    println!("What service or site is this password for?");
    let mut site = String::new();
    std::io::stdin()
        .read_line(&mut site)
        .expect("Please enter a valid string.");

    // Length
    println!("How long should your password be?");
    let mut len = String::new();
    let mut length: u32 = 0;
    while length < 8 {
        std::io::stdin()
            .read_line(&mut len)
            .expect("Unable to read line.");
        length = len.trim().parse().expect("Please type a number!");
        if length >= 8 {
            break;
        }
        println!("That's not very secure, please enter a number greater than 8.");
    }
    // Password Generation
    println!("Your password is...\n{}", generate_password(length, site));
}

fn generate_password(length: u32, site: String) -> String {
    let mut string = String::new();
    for _ in (0..length) {
        string.push(rand::random::<u8>() as char);
    }
    string
}

#[cfg(test)]
mod tests {
    use super::*;
    #[test]
    fn generate_password_test() {
        let length = 8;
        let password = generate_password(length, "site".to_string());

        assert_eq!(password.len() as u32, length);
    }
}
