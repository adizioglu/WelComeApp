"""
I want a python application, we will welcome the user to our application 
and then we will ask them their first name, then we will ask them their last name. 
Finally, we will greet them with first and last name.
"""

# main fonksiyonunu tanımlıyoruz
def main():
    # Kullanıcıya hoş geldiniz mesajı yazdırıyoruz
    print("Welcome to our application!")

    # Kullanıcıdan ilk adını girmesini istiyoruz ve first_name değişkenine atıyoruz
    first_name = input("Please enter your first name: ")
    # Kullanıcıdan soyadını girmesini istiyoruz ve last_name değişkenine atıyoruz
    last_name = input("Please enter your last name: ")

    # Kullanıcıyı tam adıyla selamlıyoruz
    print(f"Hello, {first_name} {last_name}!")

# Eğer bu dosya ana dosya olarak çalıştırılıyorsa, main fonksiyonunu çağırıyoruz
if __name__ == "__main__":
    main()
