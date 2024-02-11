
window.ShowToastr = (type, message) => {
    if (type == "success") {
        toastr.success(message, "Operación Correcta", { timeOut: 10000 });
    }
    if (type == "error") {
        toastr.error(message, "Operación Fallida", { timeOut: 10000 });
    }
}

window.ShowSwal = (type, message) => {
    if (type == "success") {
        swal.fire(
            'Notificación Exitosa',
            message,
            'success'
        );
    }
    if (type == "error") {
        swal.fire(
            'Notificación Erronea',
            message,
            'error'
        );
    }
}
