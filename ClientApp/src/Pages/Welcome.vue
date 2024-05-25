<script setup>
import { Head, Link } from '@inertiajs/vue3';
</script>

<template>
    <Head title="Welcome" />
    <div>
        <h1>Welcome</h1>
    </div>

    <ul>
        <li>
            <Link href="/Home/Authorized">Authorized (should redirect to login)</Link>
        </li>
        <li>
            <Link href="/Home/Privacy">
                Privacy (public link)
            </Link>
        </li>
    </ul>
</template>
