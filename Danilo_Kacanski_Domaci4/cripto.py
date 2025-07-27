import base64

encrypted_msg_base64 = "o/O38rGJ4ozlt+aJ6LLQsNC90LAg0L/QvtGA0YPQutCwINC90LAg0ZvQuNGA0LjQu9C40YbQuC4="
key = 'sifra12345678'

encrypted_msg = base64.b64decode(encrypted_msg_base64)
print("Encrypted message bytes:", encrypted_msg)

key_bytes = key.encode('utf-8')
print("Original key bytes:", key_bytes)


key_bytes = key_bytes.ljust(len(encrypted_msg), b'\x00')
print("Expanded key bytes:", key_bytes)

decrypted_msg_bytes = bytearray(
    [encrypted_msg[i] ^ key_bytes[i] for i in range(len(encrypted_msg))]
)

encodings = ['utf-8']

with open('decoding_results.txt', 'w', encoding='utf-8') as file:
    # Try decoding with each encoding
    for encoding in encodings:
        try:
            decoded_text = decrypted_msg_bytes.decode(encoding)
            print(decoded_text)
            file.write(f"Successfully decoded with {encoding}: {decoded_text}\n")
        except UnicodeDecodeError as e:
            file.write(f"Failed to decode with {encoding}: {str(e)}\n")
        except Exception as e:
            file.write(f"Unexpected error with {encoding}: {str(e)}\n")
