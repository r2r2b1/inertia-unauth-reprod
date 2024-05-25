import vue from '@vitejs/plugin-vue';
import laravel from 'laravel-vite-plugin';
import { defineConfig } from 'vite';
import { mkdirSync } from 'fs'
import path from 'path'

// Auto-initialize the default output directory
const outDir = "../wwwroot/build";
mkdirSync(outDir, { recursive: true });


export default defineConfig({
    plugins: [
        laravel({
            input: 'src/app.js',
            publicDirectory: outDir,
            refresh: true,
        }),
        vue({
            template: {
                transformAssetUrls: {
                    base: null,
                    includeAbsolute: false,
                },
            },
        }),
    ],
    resolve: {
        alias: {
            "@": path.resolve(__dirname, "src"),
        },
    },
    build: {
        outDir,
        emptyOutDir: true,
    },
});
