declare module 'minimist' {
    function minimist(args: string[], opts?: minimist.Options): minimist.ParsedArgs;
    namespace minimist {
        interface Options {
            string?: string | string[];
            boolean?: boolean | string | string[];
            alias?: { [key: string]: string | string[] };
            default?: { [key: string]: any };
            stopEarly?: boolean;
            '--'?: boolean;
        }
        interface ParsedArgs {
            _: string[];
            [key: string]: any;
        }
    }
    export = minimist;
}