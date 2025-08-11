declare module 'cryptiles' {
    export function hashPassword(password: string): string;
    export function verifyHash(password: string, hash: string): boolean;
}