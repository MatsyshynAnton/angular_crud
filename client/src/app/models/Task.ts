export interface Task {
    id: number;
    name: string;
    description: string;
    createdAt: Date;
    finishedAt: Date;
    taskStateId: number;
    projectId: number;
    performerId: number;
}