/** @type {import('tailwindcss').Config} */
module.exports = {
    darkMode: ['class'],
    content: ['./**/*.{razor,html}'],
    theme: {
        extend: {
            fontFamily: {
                sans: ['var(--font-sans)'],
            },
            colors: {
                border: 'rgb(var(--border) / <alpha-value>)',
                input: 'rgb(var(--input) / <alpha-value>)',
                ring: 'rgb(var(--ring) / <alpha-value>)',
                background: 'rgb(var(--background-rgb) / <alpha-value>)',
                foreground: 'rgb(var(--foreground-rgb) / <alpha-value>)',
                primary: {
                    DEFAULT: 'rgb(var(--primary-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--primary-foreground-rgb) / <alpha-value>)',
                },
                secondary: {
                    DEFAULT: 'rgb(var(--secondary-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--secondary-foreground-rgb) / <alpha-value>)',
                },
                destructive: {
                    DEFAULT: 'rgb(var(--destructive-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--destructive-foreground-rgb) / <alpha-value>)',
                },
                muted: {
                    DEFAULT: 'rgb(var(--muted-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--muted-foreground-rgb) / <alpha-value>)',
                },
                accent: {
                    DEFAULT: 'rgb(var(--accent-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--accent-foreground-rgb) / <alpha-value>)',
                },
                popover: {
                    DEFAULT: 'rgb(var(--popover-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--popover-foreground-rgb) / <alpha-value>)',
                },
                card: {
                    DEFAULT: 'rgb(var(--card-rgb) / <alpha-value>)',
                    foreground: 'rgb(var(--card-foreground-rgb) / <alpha-value>)',
                },
                lilo: {
                    DEFAULT: '#8CEAD3',
                },
            },
            borderRadius: {
                lg: 'var(--radius)',
                md: 'calc(var(--radius) - 2px)',
                sm: 'calc(var(--radius) - 4px)',
            },
            keyframes: {
                'accordion-down': {
                    from: { height: '0' },
                    to: { height: 'var(--radix-accordion-content-height)' },
                },
                'accordion-up': {
                    from: { height: 'var(--radix-accordion-content-height)' },
                    to: { height: '0' },
                },
            },
            animation: {
                'accordion-down': 'accordion-down 0.2s ease-out',
                'accordion-up': 'accordion-up 0.2s ease-out',
            },
        }
    },
    plugins: [],
}

