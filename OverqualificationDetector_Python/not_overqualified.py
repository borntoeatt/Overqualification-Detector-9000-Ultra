#!/usr/bin/env python3

import time
import random
import sys

def dramatic_print(text, delay=0.03):
    for char in text:
        print(char, end='', flush=True)
        time.sleep(delay)
    print()

def separator():
    print("\n" + "-" * 50 + "\n")

def get_input(prompt):
    return input(f"{prompt}: ").strip()

def main():
    print("\n🧠 Welcome to *Not Overqualified™* - the definitive job-fit analyzer.\n")
    separator()

    print("Please provide the following details so we can ignore them:\n")

    data = {
        "Full Name": get_input("👤 Full Name"),
        "Skills": get_input("🛠 Skills (comma-separated)"),
        "Years of Experience": get_input("📆 Years of Experience"),
        "Certifications": get_input("📜 Certifications"),
        "Education": get_input("🎓 Education"),
        "LinkedIn Profile": get_input("🔗 LinkedIn Profile URL (if any)"),
    }

    separator()
    print("🔍 Analyzing your data with our patented 'Judgment Engine™'...\n")
    time.sleep(random.uniform(1.5, 3.0))

    dots = "...thinking..."
    for char in dots:
        print(char, end='', flush=True)
        time.sleep(0.15)
    print("\n")

    responses = [
                     print(r"""
                  
                  ╔─────────────────╗
                  ║   SHAME ON YOU  ║
                  ╚─────────────────╝
""")
        #"🫡 You are not overqualified.",
        #"❌ Still not overqualified.",
        #"💡 Nope. Not even slightly overqualified.",
        #"✅ Confirmed: You are perfectly underqualified.",
        #"🤖 Result: You are not overqualified. But nice try.",
        #"🚫 Overqualification level: Zero.",
        #"🎉 Congratulations! You are not overqualified.",
        #"🧐 Analysis complete: You are not overqualified."
    ]

    # Try importing pyfiglet for ASCII art
    try:
        import pyfiglet
        def print_rejected_stamp():
            ascii_art = pyfiglet.figlet_format("REJECTED", font="slant")
            print(ascii_art)
    except ImportError:
        def print_rejected_stamp():
            print(r"""
                  
                  ╔─────────────────╗
                  ║   SHAME ON YOU  ║
                  ╚─────────────────╝
""")

    dramatic_print(random.choice(responses))

    separator()
    print("Thank you for using *Not Overqualified™*. We hope it was as pointless for you as it was for us.\n")

if __name__ == "__main__":
    try:
        main()
    except KeyboardInterrupt:
        print("\n\n🚪 Exiting with dignity.")
        sys.exit(0)
